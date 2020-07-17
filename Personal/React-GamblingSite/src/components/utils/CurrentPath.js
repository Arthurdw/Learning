// FireLoot - ©Arthurdw //
import React from 'react';

import { Link } from 'react-router-dom';

function CurrentPath(props) {
    let data = [];
    props.paths.forEach(item => data.push(props.paths[props.paths.length - 1] !== item ?
        <span key={(props.paths).indexOf(item)}><Link to={item.url}>{item.name}</Link>{' > '}</span> :
        <Link key={(props.paths).indexOf(item)} to={item.url}>{item.name}</Link>))
    return (<p id="CurrentPath">{data}</p>);
};

export default CurrentPath;
