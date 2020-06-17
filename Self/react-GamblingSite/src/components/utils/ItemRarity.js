function getRarity(ratity) {
    switch (ratity) {
        case 'industrial':
            return "#99ccff";
        case 'mil-spec':
            return "#0000ff";
        case 'restricted':
            return "#800080";
        case 'classified':
            return "#ff00ff";
        case 'covert':
            return "#ff0000";
        case 'rare':
            return "#ffcc00";
        case 'contraband':
            return "#ffcc99";
        case "consumer":
        default:
            return "#c0c0c0"
    }
}

export default getRarity;
