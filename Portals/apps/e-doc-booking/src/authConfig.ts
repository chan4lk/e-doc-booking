export const msalConfig = {
    auth: {
        clientId: '7dfbfd87-e7c5-481a-ba9b-a2b94085caf4',        
        redirectUri: "http://localhost:4200/callback",
        postLogoutRedirectUri: "/"
    }
};

// Add here scopes for id token to be used at MS Identity Platform endpoints.
export const loginRequest = {
    scopes: ["User.Read"]
};

// Add here the endpoints for MS Graph API services you would like to use.
export const graphConfig = {
    graphMeEndpoint: "https://graph.microsoft.com/v1.0/me"
};

