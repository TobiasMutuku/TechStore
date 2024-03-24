using System;
using System.Web;

public class CookieManager
{
    // Get cookie value by name
    public static string GetCookieValue(string cookieName)
    {
        HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
        return cookie != null ? cookie.Value : null;
    }

    // Set/update a cookie with a specific value and expiration time
    public static void SetCookie(string cookieName, string value, DateTime expirationDate)
    {
        HttpCookie cookie = new HttpCookie(cookieName, value);
        cookie.Expires = expirationDate;
        HttpContext.Current.Response.Cookies.Add(cookie);
    }

    // Delete a cookie by setting its expiration time to a past date
    public static void DeleteCookie(string cookieName)
    {
        HttpCookie cookie = new HttpCookie(cookieName);
        cookie.Expires = DateTime.Now.AddDays(-1);
        HttpContext.Current.Response.Cookies.Add(cookie);
    }

    // Update a cookie with a new value and/or expiration time
    public static void UpdateCookie(string cookieName, string newValue, DateTime newExpirationDate)
    {
        if (HttpContext.Current.Request.Cookies[cookieName] != null)
        {
            DeleteCookie(cookieName);
            SetCookie(cookieName, newValue, newExpirationDate);
        }
    }
}
