function select(id) {
    model.app.currentId = id;
    updateView();
}

function editMode() {
    if(model.input.isEdit === false) {model.input.isEdit = true}
    else {model.input.isEdit = false} 
    updateView();
}

function createNewFolder(currentId, text) {
    let newContent = '';
    let newId = model.filesAndFolders.length > 0 ? model.filesAndFolders[model.filesAndFolders.length - 1].id + 1 : 1;
    if (currentId === null) {
        newContent = {id: newId, name: text, isEdit: false};
    } else if (currentId != null) {
        newContent = {id: newId, name: text, parentId: currentId, isEdit: false};
    }
    model.filesAndFolders.push(newContent);
    updateView();
}
function createNewFile(currentId, text) {
    let newContent = '';
    let newId = model.filesAndFolders.length > 0 ? model.filesAndFolders[model.filesAndFolders.length - 1].id + 1 : 1;
    if (currentId === null) {
        newContent = {id: newId, name: text, content: '', isEdit: false};
    } else if (currentId != null) {
        newContent = {id: newId, name: text, parentId: currentId, content: '', isEdit: false};
    }
    model.filesAndFolders.push(newContent);
    updateView();
}

function editFileContent(currentId, myTextFile) {
    let myContent = model.filesAndFolders.find(m => m.id == currentId);
    myContent.content = myTextFile;
    model.app.currentId = myContent.parentId;
    updateView();
}

function aborteditFileContent(currentId){
    let myContent = model.filesAndFolders.find(m => m.id == currentId);
    myContent.content = myContent.content;
    model.app.currentId = myContent.parentId;
    updateView();
}

function turnEditMode() {
    if(model.input.isEdit == false) {model.input.isEdit = true}
    else {model.input.isEdit = false};
    updateView();
}

function edit(currentId) {
    let myPath = model.filesAndFolders.find(f => f.id === currentId);
    myPath.isEdit = true;
    
    
    updateView();
}

function delite(currentId) {
    let parrentId = model.filesAndFolders.find(f => f.parentId === currentId);
    model.filesAndFolders = model.filesAndFolders.filter(f => f.id != currentId);
    if (parrentId != undefined ) {
        let list = getParrentList(currentId);

        for(let i = 0; i < list.length; i++) {
            model.filesAndFolders = model.filesAndFolders.filter(f => f.id != list[i]);
        }
    }
    
    updateView();
}

function getParrentList(currentId) {
    let list = [];
    let parrentId;
    for(i = 0; i < model.filesAndFolders.length; i++) {
        
        for(j = 0; j < model.filesAndFolders.length; j++) {
            const content = model.filesAndFolders[j];
            if(content.hasOwnProperty('parentId') && content.parentId == currentId) {
                list.push(content.id);
                parrentId = content.id;
            }
        }
            currentId = list[i];

        

    }

    return list;

}


function saveEdit(currentId, text) {
    let myPath = model.filesAndFolders.find(f => f.id === currentId);
    myPath.name = text;
    myPath.isEdit = false;
    updateView();
}

function abortEdit(currentId) {
    let myPath = model.filesAndFolders.find(f => f.id === currentId);
    myPath.isEdit = false;
    updateView();
}
