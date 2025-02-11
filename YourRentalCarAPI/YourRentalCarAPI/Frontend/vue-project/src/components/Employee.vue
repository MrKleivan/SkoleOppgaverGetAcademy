<script setup>
import axios from 'axios';
import {ref, onMounted } from 'vue';

// defineProps({

// })

const employees = ref([]);

onMounted(async () => {
try {
    const response = await axios.get("https://localhost:7114/api/Employee").then(
    (response) => {
        employees.value = response.data;
    })
}
catch (error) {
    console.log('Feil ved opplasting', error);
    console.log(response)
}
});

</script>

<template>
    <div>
        <table>
            <tbody>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Stilling</th>
                    <th>Epost</th>
                    <th>Telefon</th>
                </tr>
                <tr v-for="employee in employees" :key="employee.id">
                    <td>{{employee.firstName}}</td>
                    <td>{{employee.lastName}}</td>
                    <td>{{employee.title}}</td>
                    <td>{{employee.email}}</td>
                    <td>{{employee.phoneNumber}}</td>
                </tr>
            </tbody>
        </table>
    </div>

</template>

<style>


th {
    width: 400px;
    background-color: slategray;
}

td {
    text-align: center;
}

tr:nth-child(even){
    background-color: white;
    color: black;
}
</style>