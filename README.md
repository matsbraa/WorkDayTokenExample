# WorkDayTokenExample

This repository shows how a daemon app can fetch a token from Azure AD which is then used to authenticate against the Kursportalen-API.
The example is in C# but can easily be converted to any programming language.

This console app creates an HTTP request using the HTTP-POST method and adds grant-type, client-secret, client-id & scope as request parameters.

To run this insert ids and secrets at appropriate places on line 14 in the Program.cs file.
When the program executes the response body will be printed in the console window, when successful it will print the bearer token, otherwise, an error will be printed.
