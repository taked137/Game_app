//
//  GetUserRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct GetUserRequest {

    let token: String
}

// MARK: - TargetType

extension GetUserRequest: TargetType {

    var path: String {
        return "/user/me"
    }

    var method: Moya.Method {
        return .get
    }
    
    var headers: [String: String]? {
        return ["Authorization": "Bearer \(token)"]
    }

    var task: Task {
        return .requestPlain
    }
}
