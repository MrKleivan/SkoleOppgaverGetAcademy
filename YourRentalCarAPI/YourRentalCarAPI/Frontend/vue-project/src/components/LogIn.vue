<script setup>
import axios from 'axios'
import { ref } from 'vue';
import { useRouter } from 'vue-router'
import form  from './acsess.vue'

const router = useRouter();

const Email = ref();
const Password = ref();


const accessData = (async () => {
    try {
        const response = await axios.post("/login", {email: Email.value, password: Password.value}).then(
        (response) => {
            form.isLoggedInn = true;
            form.acsessToken = response.data.tokenType + " " + response.data.accessToken;
        })
        router.push("/intra")
    }
    catch (error) {
        alert('Feil ved brukernavn eller passord', error);
        console.log(form.acsessToken.value);

    }
    Email.value = "";
    Password.value = "";
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




