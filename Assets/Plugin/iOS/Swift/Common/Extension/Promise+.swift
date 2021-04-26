//
//  Promise+.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/16.
//

import PromiseKit

extension Promise where T == String {

    func waitWithResult() -> Result<T> {
        do {
            return Result.fulfilled(try wait())
        } catch {
            return Result.rejected(error)
        }
    }
}
