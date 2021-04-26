//
//  GetTermRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct GetTermRequest {
}

// MARK: - TargetType

extension GetTermRequest: TargetType {

    var path: String {
        return "/term"
    }

    var method: Moya.Method {
        return .get
    }

    var headers: [String: String]? {
        return [:]
    }

    var task: Task {
        return .requestPlain
    }
}
