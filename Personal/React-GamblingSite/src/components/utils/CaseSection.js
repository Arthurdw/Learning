// FireLoot - ©Arthurdw //
import React from 'react';

import CaseSectionCase from './CaseSectionCase';

class CaseSection extends React.Component {
    render() {
        return (
            <div className="CaseSection">
                <div className="CaseSectionDistributer">
                    <h3 className="CaseSectionTitle">{this.props.title}</h3>
                    <p className="CaseSectionDescription">{this.props.description}</p>
                    <div className="CaseSectionCaseDistributor">
                        {this.props.cases.map(element => <CaseSectionCase key={(this.props.cases).indexOf(element)} name={element.name} image={element.image} price={element.price} url={element.url} />)}
                    </div>
                </div>
            </div>
        )
    };
};

export default CaseSection;
