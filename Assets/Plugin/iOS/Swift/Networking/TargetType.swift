//
//  APITargetType.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/18.
//

import Moya

extension TargetType {

    var baseURL: URL {
        return URL(string: AppConstant.baseURL)!
    }

    var validationType: ValidationType {
        return .successCodes
    }

    var sampleData: Data {
        return Data()
    }
}

typealias Parameters = [String: Any]