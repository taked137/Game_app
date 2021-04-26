using System;
using System.Threading.Tasks;

public static class TaskExtension {
    
    public static async void flod<T>(this Task<T> task, Action<T> onSuccess, Action<Exception> onFailure) {
        try {
            T result = await task;
            onSuccess(result);
        } catch (Exception exception) {
            onFailure(exception);
        }
    }
}