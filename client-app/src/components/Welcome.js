import React, { Fragment } from 'react';
import { useAuth0 } from "../react-auth0-spa";

const Welcome = () => {
    const { loading, user } = useAuth0();

    if (loading || !user) {
      return <div>Loading...</div>;
    }
    return (
      <Fragment>
        <p>Welcome {user.name} !</p>
      </Fragment>
    );
}

export default Welcome;
