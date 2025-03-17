


function isLetter(c) {
    return c.toLowerCase() != c.toUpperCase();
}

function reverseText(str) {
    return str.split('').reverse().join('');
}
function cleanText(text) {
    let word = '';
    for(i = 0; i < text.length; i++) {
        if (isLetter(text.charAt(i)) == true) {
            word += text.charAt(i);
        }
    }
    word = word.toLowerCase();
    return word;
}
function isPalindrome(text){
    text = cleanText(text);
    let reversText = reverseText(text);
    if (reversText == text){
    return true;
    } return false;
}
