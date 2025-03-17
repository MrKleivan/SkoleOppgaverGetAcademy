function updateView() {
    let currentId = model.app.currentId;
    let html;
    if(model.input.isEdit != false) {
        html = /*HTML*/`
            <h1>Filer og mapper</h1>
            Du er her: ${createSummarySelected()}<br/>
            <input id="newInput" /><button onclick="editMode()">Avbryt</button><br/>
            <button onclick="createNewFolder(${currentId}, newInput.value)">Ny mappe</button><button onclick="createNewFile(${currentId}, newInput.value)">Ny fil</button><br/>
            ${createFoldersHtml()}
            ${createFilesHtml()}
            ${createEditFileHtml()}
        `;
    }
    else {
        html = /*HTML*/`
            <h1>Filer og mapper</h1>
            Du er her: ${createSummarySelected()}<br/>
            <button onclick="editMode()">Ny</button><br/>
            ${createFoldersHtml()}
            ${createFilesHtml()}
            ${createEditFileHtml()}
        `;
    }

    document.getElementById('app').innerHTML = html;
}

function createSummarySelected() {
    let id = model.app.currentId;
    if (id == null) return '<i>rotmappe</i>';
    let breadcrumbs = '';
    while (id) {
        let fileOrFolder = model.filesAndFolders.find(f => f.id == id);
        if (breadcrumbs != '') breadcrumbs = ' > ' + breadcrumbs;
        breadcrumbs = fileOrFolder.name + breadcrumbs;
        id = fileOrFolder.parentId;
    }
    return breadcrumbs;
}

function createFoldersHtml() {
    let currentId = model.app.currentId;
    const currentFileOrFolder = model.filesAndFolders.find(f => f.id == currentId);
    let html = '';
    if (currentFileOrFolder != null) {
        html = `📁 <a href="javascript:select(${currentFileOrFolder.parentId})">..</a><br/>`;
        if (currentFileOrFolder.hasOwnProperty('content')) currentId = currentFileOrFolder.parentId;
    }
    for (let folder of model.filesAndFolders) {
        if (folder.hasOwnProperty('content') || folder.parentId != currentId) continue;
        if (folder.isEdit != true) {
            html += /*HTML*/`📁 <a href="javascript:select(${folder.id})">${folder.name}</a><button onclick="edit(${folder.id})">Rediger</button><button onclick="delite(${folder.id})">Slett</button><br/>`;
        } else { 
            let name = folder.name;
            if(name.includes('.')) {
                name = name.replaceAll('.','')
            }
            if(name.includes(' ')) {
                name = name.replaceAll(' ','')
            }
            html += /*HTML*/`📁 <input id="${name}" value="${folder.name}"/>
                    <button onclick="saveEdit(${folder.id}, ${name}.value)">Lagre</button>
                    <button onclick="abortEdit(${folder.id})">Avbryt</button><br/>`;
        }
    }
    return html;
}

function createFilesHtml() {
    let currentId = model.app.currentId;
    const currentFileOrFolder = model.filesAndFolders.find(f => f.id == currentId);
    if (currentFileOrFolder != null) {
        if (currentFileOrFolder.hasOwnProperty('content')) currentId = currentFileOrFolder.parentId;
    }
    let html = '';
    for (let file of model.filesAndFolders) {
        if (!file.hasOwnProperty('content') || file.parentId != currentId) continue;
        
        if(file.isEdit != true) {
            html += /*HTML*/`<span>🗎</span> <a href="javascript:select(${file.id})">${file.name}</a><button onclick="edit(${file.id})">Rediger</button><button onclick="delite(${file.id})">Slett</button><br/><br/>`;
        } else {
            let name = file.name;
            if(name.includes('.')) {
                name = name.replaceAll('.','')
            }
            if(name.includes(' ')) {
                name = name.replaceAll(' ','')
            }
            html += /*HTML*/`<input id="${name}" value="${file.name}"/>
            <button onclick="saveEdit(${file.id}, ${name}.value)">Lagre</button>
            <button onclick="abortEdit(${file.id})">Avbryt</button><br/>`;
        }

    }
    return html;
}

function createEditFileHtml() {
    const currentId = model.app.currentId;
    if (currentId == null) return '';
    const currentFile = model.filesAndFolders.find(f => f.id == currentId);
    if (!currentFile.hasOwnProperty('content')) return '';
    return /*HTML*/`
        <textarea id="myTextFile">${currentFile.content}</textarea>    
        <br/>
        <button onclick="editFileContent(${currentId}, myTextFile.value)">Lagre</button>
        <button onclick="aborteditFileContent(${currentId})">Avbryt</button>
    `;
}