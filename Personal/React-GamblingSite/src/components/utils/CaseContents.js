import React from 'react';

import CaseSkin from './CaseSkin';

// {name: "Knife", skin: "Unknown", rarity: "rare", image: "/./assets/skins/rare.webp"}

function CaseContents(props) {
    return (
        <div id="CaseContainsContainer">
            <div id="CaseContains">
                {props.items.map(item => <CaseSkin key={(props.items).indexOf(item)} skin={item} />)}
            </div>
        </div>
    );
};

export default CaseContents;
