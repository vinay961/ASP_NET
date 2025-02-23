# Cookies in ASP.NET MVC
- Cookies are one of the state management techniques, so that we can store information for later use. 
- Cookies are small files that are created in the web browser.
- Cookies are sent to the client computer along with the page output.

## Type of cookie are
- Non Persistent Cookie or Session Cookie: Those cookie which get destroyed once the browser closes.
- Persistent Cookie: We can set a fixed time period for the cookie, after that time cookie destroyed.

## Syntax for Non-Persistent Cookie

`To set the cookie follow below steps:`
1. httpCookie cookie = new HttpCookie(`<CookieName>`)
2. cookie.Value = `<Some_value>`
3. HttpContext.Response.Cookies.Add(cookie)

`To get the cookie follow below steps:`
1. HttpCookie cookie = Request.Cookie[`<CookieName>`]