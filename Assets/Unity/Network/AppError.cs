using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppError: Exception {

    // MARK: - Property
    
    public ErrorKind kind;

    // MARK: - Initializer

    public AppError(ErrorKind kind) {
        this.kind = kind;
    }

    public AppError(string statusCode) {
        switch (statusCode) {
            case "401":
                this.kind = ErrorKind.unauthorized;
                break;

            case "402":
                this.kind = ErrorKind.badrequest;
                break;

            case "403":
                this.kind = ErrorKind.forbidden;
                break;

            case "404":
                this.kind = ErrorKind.notfound;
                break;

            case "500":
            case "501":
            case "502":
            case "503":
                this.kind = ErrorKind._internal;
                break;
        }
    }

    // MARK: - Builder

    public static void checkError(string statusCode) {
        if (statusCode.Length == 3 && int.Parse(statusCode) >= 400) {
            throw new AppError(statusCode);
        }
    }

    public static void checkError(int statusCode) {
        if (statusCode >= 400) {
            throw new AppError("" + statusCode);
        }
    }
}

public enum ErrorKind {
        unauthorized,
        badrequest,
        forbidden,
        notfound,
        _internal,
        network,
    }