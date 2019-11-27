using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.Helpers
{
    public static class Extenstions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Applications-Error", message);
            response.Headers.Add("Applications-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Applications-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
                age--;
            return age;
        }

    }

}