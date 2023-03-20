updateView()

async function updateView(){
    let html="";
    html+=`
    <div class="Header">
        <h3 class="SiteName">IMDB clone</h3> 
        <input class="User_Search" type="text">
    </div>
    ${await SelectView()}
    `;
    document.getElementById("app").innerHTML=html;
}

async function SelectView(){
    let html ="";
    switch (model.app.currentPage) {
        case "Main":
            html+=await HomePage();
            break;
    }
    return html;
}