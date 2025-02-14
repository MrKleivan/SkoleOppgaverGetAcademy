<script setup>
import axios from 'axios';
import {ref, onMounted } from 'vue';
import form from './acsess.vue';
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

onMounted( () => UpdateEmployeeList());

const UpdateEmployeeList = (async () => {
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
        const response = await axios.post("https://localhost:7114/api/Employee", {firstName: employee.FirstName.value,
                lastName: employee.LastName.value,
                title: employee.Title.value,
                phoneNumber: employee.PhoneNumber.value,
                email: employee.Email.value},
        {
            headers: {
                Authorization: form.acsessToken, 
            }
        });
        console.log(employee)
        employee.FirstName.value = "";
        employee.LastName.value = "";
        employee.Title.value = "";
        employee.PhoneNumber.value = 0;
        employee.Email.value = "";
    }
    catch (error) {
        alert("Feil", error);
        console.log(error)
    }
    UpdateEmployeeList();
});

const DeleteEmployee = (async (id) => {
    try {
        const response = await axios.delete("https://localhost:7114/api/Employee/" + id, {"action": "dashboard"}
        // {
        //     // headers: {
        //     //     Authorization: form.acsessToken,
        //     // }
        // }
    );
    }
    catch (error) {
        console.log("Feil", error);
    }
    UpdateEmployeeList();
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
                    <td><input v-model="employee.LastName.value"/></td>
                    <td><input v-model="employee.Title.value"/></td>
                    <td><input v-model="employee.PhoneNumber.value"/></td>
                    <td><input v-model="employee.Email.value"/></td>
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
    width: 95%;
    border-radius: 5px;
    border: none;
}

input:focus {
    background-color: rgb(177, 235, 235);
    border: none;
}
</style>