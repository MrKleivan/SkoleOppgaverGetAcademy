function s1funksjon(tagElement, alt1, alt2, alt3, alt4) {
    if (document.getElementById(alt1).innerHTML == '') {
        document.getElementById(alt1).innerHTML = tagElement.innerHTML;
        tagElement.innerHTML = '';
    }
    if (document.getElementById(alt2).innerHTML == '') {
        document.getElementById(alt2).innerHTML = tagElement.innerHTML;
        tagElement.innerHTML = '';
    }
    if (document.getElementById(alt3).innerHTML == '') {
        document.getElementById(alt3).innerHTML = tagElement.innerHTML;
        tagElement.innerHTML = '';
    }
    if (document.getElementById(alt4).innerHTML == '') {
        document.getElementById(alt4).innerHTML = tagElement.innerHTML;
        tagElement.innerHTML = '';
    }
}

let spillh1 = document.getElementById('spillh1');
var spill1 = document.getElementById('spill1');
spill1.style.display = 'none';

const tallid = document.getElementById('tallid');

var oppgave = document.getElementById('oppgave');
oppgave.style.display = 'none';

function spillvalg() {
    spill1.style.display = 'block';
    spillh1.innerHTML = 'Spill 1';
    oppgave.style.display = 'none';
}

function oppgaver() {
    spillh1.innerHTML = 'Oppgave';
    spill1.style.display = 'none';
    oppgave.style.display = 'block';
}


function oppnedknappopp(tagElement) {
    tagElement = tallid.innerHTML;
    tagElement = tagElement -+ -1;
    tallid.innerHTML = tagElement;
}

function oppnedknappned(tagElement) {
    tagElement = tallid.innerHTML;
    tagElement = tagElement -+ 1;
    tallid.innerHTML = tagElement;
}