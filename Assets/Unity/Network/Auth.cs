using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Firebase;
using Firebase.Auth;

public class Auth {

    // MARK: - Static

    public static Auth shared = new Auth();

    // MARK: - Property

    public FirebaseAuth auth;

    // MARK: - Public

    public bool isSignedIn() {
        return auth.CurrentUser != null;
    }

    public async Task<FirebaseUser> signIn() {
        if (isSignedIn()) {
            Debug.Log("ログイン済み");
            return auth.CurrentUser;
        }

        return await auth.SignInAnonymouslyAsync();
    }

    public async Task<string> getIdToken() {
        return await Task.Run<string>(() => {
            if (!isSignedIn()) {
                throw new AppError(ErrorKind.unauthorized);
            }

            return auth.CurrentUser.TokenAsync(false);
        });
    }

    // MARK: - Initializer

    private Auth() {
        auth = FirebaseAuth.DefaultInstance;
    }
}