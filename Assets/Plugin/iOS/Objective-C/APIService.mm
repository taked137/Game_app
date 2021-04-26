//
//  APIService.m
//  Unity-iPhone
//
//  Created by kntk on 2019/09/17.
//

#import "unityswift-Swift.h"

extern "C" {

    const char* _getTerm() {
        const char *str = [APIService getTerm].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }

    const char* _postUserRegister(const char* token, const char* userName) {
        const char *str = [APIService postUserRegisterWithToken: [NSString stringWithUTF8String: token] userName: [NSString stringWithUTF8String: userName]].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }

    const char* _getUser(const char* token) {
        const char *str = [APIService getUserWithToken: [NSString stringWithUTF8String: token]].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }

    const char* _getMonsters(const char* token) {
        const char *str = [APIService getMonstersWithToken: [NSString stringWithUTF8String: token]].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }

    const char* _getMonstersMap(const char* token) {
        const char *str = [APIService getMonstersMapWithToken: [NSString stringWithUTF8String: token]].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }

    const char* _putMonsterGet(const char* token, const char* Id) {
        const char *str = [APIService putMonsterGetWithToken: [NSString stringWithUTF8String: token] id: [NSString stringWithUTF8String: Id]].UTF8String;
        char* retStr = (char*)malloc(strlen(str) + 1);
        strcpy(retStr, str);
        retStr[strlen(str)] = '\0';

        return retStr;
    }
}
