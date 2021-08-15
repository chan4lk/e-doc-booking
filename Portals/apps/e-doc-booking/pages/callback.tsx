import React from "react";
import { AuthenticatedTemplate, UnauthenticatedTemplate } from "@azure/msal-react";
import Button from "@material-ui/core/Button";
import Typography from "@material-ui/core/Typography";

export default function Home() {
  
  return (
      <>
          <AuthenticatedTemplate>
              <Button variant="contained" color="primary" href="/profile">Request Profile Information</Button>
          </AuthenticatedTemplate>

          <UnauthenticatedTemplate>
            <Typography variant="h6">
              Please sign-in to see your profile information.
            </Typography>
          </UnauthenticatedTemplate>
      </>
  );
}