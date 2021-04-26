//
//  APIService.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Foundation
import Moya

final class APIService: NSObject {

    @objc static func getTerm() -> String {
        let result = API.shared.call(GetTermRequest()).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }

    @objc static func postUserRegister(token: String, userName: String) -> String {
        let result = API.shared.call(PostUserRegisterRequest(token: token, userName: userName)).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }

    @objc static func getUser(token: String) -> String {
        let result = API.shared.call(GetUserRequest(token: token)).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }

    @objc static func getMonsters(token: String) -> String {
        let result = API.shared.call(GetMonstersRequest(token: token)).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }

    @objc static func getMonstersMap(token: String) -> String {
        let result = API.shared.call(GetMonstersMapRequest(token: token)).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }

    @objc static func putMonsterGet(token: String, id: String) -> String {
        let result = API.shared.call(PutMonstersGetRequest(token: token, id: id)).waitWithResult()

        switch result {
        case .fulfilled(let json):
            return json
        case .rejected(let error):
            return "\((error as? NetworkingError)?.statusCode ?? 700)"
        }
    }
}
