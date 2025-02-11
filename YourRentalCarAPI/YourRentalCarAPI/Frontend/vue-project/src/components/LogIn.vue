<script setup>
import axios from 'axios'
import { ref } from 'vue';



const Email = ref();
const Password = ref();
const access = ref();


const changeData = (text, value) => {
    if(text == "Email"){
        Email.value = value;
    } 
    else if(text == "Password"){
        Password.value = value;
    }
};

const accessData = (async () => {
    try {
        const response = await axios.post("https://localhost:7114/login", {email: Email.value, password: Password.value}).then(
        (response) => {
            access.value = response.data.tokenType + " " + response.data.accessToken;
            console.log(access.value)
        })
    }
    catch (error) {
        console.log('Feil ved opplasting', error);
        console.log(Email.value + "  " + Password.value)
    }
});


    


</script>

<template>
    <label for="email">Email:</label>
    <input id="email" v-model="Email" type="text"/>
    <br />
    <label for="password">Passord:</label>
    <input id="password" v-model="Password" type="text"/>
    <br />
    <button @click="accessData">Logg Inn</button>
    <button @click="">Registrer</button>
</template>

<style>

input {
    border-radius: 5px;
    border: none;
    margin-left: 1em;
}

button {
    width: 30%;
    border-radius: 5px;
    border: none;
    margin-left: 2em;
}

</style>




