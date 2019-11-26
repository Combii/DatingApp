using Microsoft.AspNetCore.Http;

namespace DatingApp.Helpers
{
    public static class Extenstions
    {
        public static void AddApplicationError(this HttpResponse response, string message){
            response.Headers.Add("Applications-Error", message);
            response.Headers.Add("Applications-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Applications-Control-Allow-Origin", "*");
        }
    }
}