


function isLetter(c) {
    return c.toLowerCase() != c.toUpperCase();
}

function reverseText(str) {
    return str.split('').reverse().join('');
}
function cleanText(hei) {
    let heiaHeia = '';
    for(i = 0; i < hei.length; i++) {
        if (isLetter(hei.charAt(i)) == true) {
            heiaHeia += hei.charAt(i);
        }
    }
    heiaHeia = heiaHeia.toLowerCase();
    return hei = heiaHeia.replaceAll(' ', '');
}

function isPalindrome(text){
    text = cleanText(text);
    let textOne = text;
    textOne = cleanText(textOne);
    textOne = reverseText(textOne);
    if (textOne == text){
    return true;
    } else {return false;}
}
