import React from 'react';
import Dashboard from './Dashboard';
import { useAuth0 } from "../react-auth0-spa";
import CircularProgress from '@material-ui/core/CircularProgress';

const Home = () => {
  const { isAuthenticated, loginWithRedirect, loading } = useAuth0();
  if (loading) {
    return <div><CircularProgress variant="determinate" color="secondary" /></div>;
  }
  return (
    <div>
      {!isAuthenticated && (
         loginWithRedirect()
      )}

      {isAuthenticated && (
        <Dashboard />
      )}
    </div>
  );
}

export default Home;
