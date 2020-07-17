// FireLoot - ©Arthurdw //
import React from 'react';

import RecentBar from '../utils/RecentBar';
import CaseOpener from '../utils/CaseOpener';
import CurrentPath from '../utils/CurrentPath';
import CaseContents from '../utils/CaseContents';

function CaseContent(props) {
    return (
        <main id="CaseContent">
            <RecentBar />
            <div id="MainCaseContent">
                <CurrentPath paths={props.pathInfo} />
                <h1>{props.name}</h1>
                <CaseOpener price={props.price} items={props.contents} />
                <h2>Case Contains</h2>
                <CaseContents items={props.contents} />
            </div>
        </main>
    );
};

export default CaseContent;
