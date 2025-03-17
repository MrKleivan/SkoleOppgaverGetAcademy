const model = {
    app: {
        currentId: null,
    },    
    input: {
        isEdit: false
    },
    filesAndFolders: [
        {id: 1, name: 'Handlelister',},
        {id: 2, name: 'Ting som skal fikses', isEdit: false},
        {id: 3, name: 'Oktober', parentId: 1, isEdit: false},
        {id: 4, name: 'Tirsdag 15', parentId: 3, content: 'melk\nbrød\nost\n', isEdit: false},
        {id: 5, name: 'Bad', parentId: 2, content: 'Lekkasje, bla bla', isEdit: false},
        {id: 6, name: 'notater.txt', content: 'abc', isEdit: false},
    ],
};