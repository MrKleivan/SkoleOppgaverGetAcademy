

function checkIfEmaleAddress(text) {
    let mysign = text.indexOf('@');
    if (text.substr(0, mysign).includes('.') && text.includes('@') && text.substr(mysign).includes('.')) {
        return true;
    } else {return false;}
}