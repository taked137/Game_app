//
//  PostUserRegisterRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct PostUserRegisterRequest {

    let token: String
    let userName: String
}

// MARK: - TargetType

extension PostUserRegisterRequest: TargetType {

    var path: String {
        return "/user/register"
    }

    var method: Moya.Method {
        return .post
    }

    var headers: [String: String]? {
        return ["Authorization": "Bearer \(token)"]
    }

    var task: Task {
        let parameters: Parameters = [
            "userName": userName
        ]
        return .requestParameters(parameters: parameters, encoding: JSONEncoding.default)
    }
}
