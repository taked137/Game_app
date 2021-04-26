import Moya
import PromiseKit

final class API {

    static let shared = API()

    private let provider: MoyaProvider<MultiTarget>

    func call<R: TargetType>(_ request: R) -> Promise<String> {
        let target = MultiTarget(request)
        return Promise { resolver in
            self.provider.request(target) { response in
                switch response.result {
                case .success(let result):
                    do {
                        resolver.fulfill(try result.mapString())
                    } catch {
                        resolver.reject(error)
                    }
                case .failure(let error):
                    resolver.reject(NetworkingError(error: error))
                }
            }
        }
    }

    // MARK: - Private

    private init() {
        let configuration = URLSessionConfiguration.default
        configuration.httpAdditionalHeaders = Manager.defaultHTTPHeaders
        configuration.timeoutIntervalForRequest = 30

        let manager = Manager(configuration: configuration)
        manager.startRequestsImmediately = false

        provider = MoyaProvider<MultiTarget>(manager: manager,
                                             plugins: [LoggerPlugin()])
    }
}
