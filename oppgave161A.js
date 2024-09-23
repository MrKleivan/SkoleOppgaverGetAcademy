let myText;
let firstLetter;

function fixText(text) {
    text = text.trim();
    let firstLetter = text.charAt(0);
    myText = text.replace(firstLetter, firstLetter.toUpperCase());
    return myText;
    
}