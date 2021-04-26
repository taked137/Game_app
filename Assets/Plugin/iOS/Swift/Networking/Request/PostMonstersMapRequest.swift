//
//  GetMonstersMapRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct PostMonstersMapRequest {

    let token: String
    let latitude: String
    let longitude: String
}

// MARK: - TargetType

extension PostMonstersMapRequest: TargetType {

    var path: String {
        return "/monsters/map"
    }

    var method: Moya.Method {
        return .post
    }

    var headers: [String: String]? {
        return ["Authorization": "Bearer \(token)"]
    }

    var task: Task {
        let parameters: Parameters = [
            "latitude": latitude,
            "longitude": longitude
        ]
        return .requestParameters(parameters: parameters, encoding: JSONEncoding.default)
    }
}
