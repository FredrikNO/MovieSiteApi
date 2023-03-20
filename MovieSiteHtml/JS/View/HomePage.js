 async function HomePage(){
    let html="";
    html=`
    <div class="pageInfo">
        <div >IMDB clone Charts:</div>
        <div >IMDB clone Top 10 Movies:</div>    
    </div>
    
    <div class="mainContainer">
            ${await FillPage()}
    </div>
    `;
    return html;
}

async function FillPage(){
    await getUserData();
    let html="";
    for (let i = 0; i < model.movies.length; i++) {
        html += `
            <div class="HomePageInfo">
                <img class="homePageImg" src="${model.movies[i].imageSrc}" alt="">
                <div>${model.movies[i].title} (${new Date(model.movies[i].releaseDate).getFullYear()})</div>
                <div>${model.movies[i].score}</div>
            </div>
            `
        };
    
    return html;
}