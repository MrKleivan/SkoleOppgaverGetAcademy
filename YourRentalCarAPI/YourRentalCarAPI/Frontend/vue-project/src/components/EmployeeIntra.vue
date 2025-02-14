<script setup>
import axios from 'axios';
import {ref, onMounted } from 'vue';
import form from './acsess.vue'
import { useRouter } from 'vue-router';

const router = useRouter();

const employees = ref([]);
const employee = {
    FirstName: ref(),
    LastName: ref(),
    Title: ref(),
    Email: ref(),
    PhoneNumber: ref(),
};

onMounted(async () => {
try {
    const response = await axios.get('/api/Employee').then(
    (response) => {
        employees.value = response.data;
    })
}
catch (error) {
    console.log('Feil ved opplasting', error);
    console.log(employees.value)
}
});

const addEmployee = (async () => {
    try {
        const response = await axios.post("https://localhost:7114/api/Employee", {"action" : "dashboard"},
        {
            action: {
                firstName: employee.FirstName,
                lastName: employee.LastName,
                title: employee.Title,
                phoneNumber: employee.PhoneNumber,
                email: employee.Email
            },
            headers: {
                Authorization: form.acsessToken,
            }
        });
        console.log(employee)
        employee.FirstName = "fvfd";
        employee.LastName = "vds";
        employee.Title = "dv";
        employee.PhoneNumber = 0;
        employee.Email = "";
        router.push('/intraEmployee');
    }
    catch (error) {
        alert("Feil", error);
        console.log(error)
    }
});

const DeleteEmployee = (async (id) => {
    try {
        const response = await axios.delete("https://localhost:7114/api/Employee/" + id
        // {
        //     // action: theEmployee,
        //     // headers: {
        //     //     Authorization: form.acsessToken,
        //     // }
        // }
    );
    router.push('/intraEmployee');
    }
    catch (error) {
        console.log("Feil", error);
    }
})

</script>

<template>
    <div>
        <table>
            <tbody>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Stilling</th>
                    <th>Telefon</th>
                    <th>Epost</th>
                    <th>Buttons</th>
                </tr>
                <tr v-for="employee in employees" :key="employee.id">
                    <td>{{employee.firstName}}</td>
                    <td>{{employee.lastName}}</td>
                    <td>{{employee.title}}</td>
                    <td>{{employee.phoneNumber}}</td>
                    <td>{{employee.email}}</td>
                    <td><button @click="UpdateEmployee(employee.id)">Update</button><button @click="DeleteEmployee(employee.id)">Delite</button></td>
                </tr>
            </tbody>
        </table>
        <br />
        <table>
            <tbody>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Stilling</th>
                    <th>Telefon</th>
                    <th>Epost</th>
                    <th>Buttons</th>
                </tr>
                <tr>
                    <td><input v-model="employee.FirstName.value"/></td>
                    <td><input v-model="employee.LastName"/></td>
                    <td><input v-model="employee.Title"/></td>
                    <td><input v-model="employee.PhoneNumber"/></td>
                    <td><input v-model="employee.Email"/></td>
                    <td><button @click="addEmployee">AddWorker</button></td>
                </tr>
            </tbody>
        </table>
    </div>

</template>

<style>

table {
    width: 80%;
    margin: auto;
    background-color:azure;
    border-collapse: collapse;
    border-radius: 10px;
    overflow: hidden;
}

table tr:first-child {
    border-radius: 10px;
}

th {
    width: 400px;
    height: 4vh;
    background-color:  white;
    border-bottom: solid lightgrey;
}


td {
    text-align: center;
    height: 3vh;
}

tr:nth-child(even){
    background-color: rgba(255, 255, 255, 0.2);
    color: black;
}

tr:nth-child(odd){
    background-color: rgba(255, 255, 255, 0.9);
    color: black;
}

input {
    width: 100%;
}
</style>