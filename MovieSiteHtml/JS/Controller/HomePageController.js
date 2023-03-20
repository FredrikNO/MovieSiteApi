async function getUserData(){

    let result = await axios.get("https://localhost:7059/Movies");
    model.movies=result.data;
    console.log(model.movies);

}