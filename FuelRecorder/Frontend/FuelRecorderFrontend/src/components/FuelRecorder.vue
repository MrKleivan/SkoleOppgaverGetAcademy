<script setup>
import { reactive, ref } from 'vue';
import { onMounted } from 'vue';


const FuelRecords = ref([]);
const error = ref(null);
const loading = ref(false);

const FuelRecord = reactive({
    kilometer: '',
    fuelFilled: '',
    price: ''
});


const GetRecords = async () =>  {
    loading.value = true;
    error.value = null;
    FuelRecords.value = [];
    try {
        const token = localStorage.getItem('jwtToken');
        if(!token){
            throw new Error('Ingen token funnet. Vennligst logg inn');
        }
        const response = await fetch('/FuelRecorder', {
            method: "GET",
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            }
        });
        if (!response.ok) {
            throw new Error(`Feil ved opplasting av data. Status: ${response.status}`)
        }
        
        
        FuelRecords.value = await response.json();
    }
    catch (err) {
        error.value = err.message;
    } finally {
        loading.value = false;
    }
};
onMounted(GetRecords);

const AddRecord = async () => {
    loading.value = true;
    error.value = null;
    try {
        const token = localStorage.getItem('jwtToken');
        if(!token){
            throw new Error('Ingen token funnet. Vennligst logg inn');
        }
        const response = await fetch('/FuelRecorder', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            body: JSON.stringify({
                Kilometer: FuelRecord.kilometer,
                FuelFilled: FuelRecord.fuelFilled,
                Price: FuelRecord.price
            }),
        });
        if (!response.ok) {
            throw new Error(`Feil ved opplasting av data. Status: ${response.status}`)
        }
        FuelRecord.kilometer = '';
        FuelRecord.fuelFilled = '';
        FuelRecord.price = '';
        await GetRecords();
    }
    catch (err) {
        error.value = err.message;
    } finally {
        loading.value = false;
    }
}

const DeleteRecord = async (id) => {
    loading.value = true;
    error.value = null;
    try {
        const token = localStorage.getItem('jwtToken');
        if(!token){
            throw new Error('Ingen token funnet. Vennligst logg inn');
        }
        const response = await fetch(`/FuelRecorder/${id}`, {
            method: "DELETE",
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
        });
        if (!response.ok) {
            throw new Error(`Oppstått feil prøv igjenn`)
        }

        await GetRecords();
    }
    catch (err) {
        error.value = err.message;
    } finally {
        loading.value = false;
    }
}

</script>

<template>
    <div>
        <div v-if="loading">Laster data...</div>
        <div v-if="error" class="error">{{ error }}</div>
        <span>
            <p>Dine registreringer</p>
        </span>
        
        <table>
            <tbody>
                <tr>
                    <th>Kilometer</th>
                    <th>Mengde drivstoff fyldt</th>
                    <th>Betalt</th>
                    <th>•••</th>
                </tr>
                <tr v-for="record in FuelRecords" :key="record.id">
                    <td>{{ record.kilometer }}</td>
                    <td>{{ record.fuelFilled }}</td>
                    <td>{{ record.price }}</td>
                    <td @click="DeleteRecord(record.id)">Slett</td>
                </tr>
            </tbody>
        </table>
        <span>
            <p>Ny registrering</p>
        </span>
        <table>
            <tbody>
                <tr>
                    <th>Kilometer</th>
                    <th>Mengde drivstoff fyldt</th>
                    <th>Betalt</th>
                </tr>
                <tr>
                    <td><input type="text" v-model="FuelRecord.kilometer"/></td>
                    <td><input type="text" v-model="FuelRecord.fuelFilled"/></td>
                    <td><input type="text" v-model="FuelRecord.price"/></td>
                </tr>
            </tbody>
        </table>
            <button @click="AddRecord">Legg til</button>
        
        
    </div>

</template>

<style scoped>

div {
    width: 70%;
    height: 100%;
    text-align: center;
    margin: auto;
}


table {
    width: 70%;
    margin: auto;
    padding: 1em;
    border-top: 5px double rgba(36, 91, 107, 0.842);
    border-bottom: 5px double rgba(36, 91, 107, 0.842);
    text-align: center;
    color: rgba(96, 183, 209, 0.842);
}

span {
    font-family: 'Courier New', Courier, monospace;
    font-size: medium;
    font-weight: bolder;
    color: rgb(23, 102, 126);
}


th {
    width: 30%;
    height: 3vh;
    background-color: rgba(36, 91, 107, 0.842);
    border-radius: 5px;
}


td {
    height: 4vh;
    border-radius: 5px;
}
td:last-child {
    width: 10%;
}
td:nth-child(4):hover {
    width: 10%;
    background-color: aliceblue;
    cursor: pointer;
}
tr:nth-child(odd) {
    background-color: rgba(36, 91, 107, 0.7);
}
tr:nth-child(even) {
    background-color: rgba(36, 91, 107, 0.4);
}

button {
    width: 200px;
    height: 20px;
    border-radius: 4px;
    margin-top: 1em;
    background-color: rgb(41, 49, 56);
    font-family: 'Courier New', Courier, monospace;
    color: aliceblue;
    transition-duration: 4s;
}

button:hover {
    background-color: rgba(41, 49, 56, 0.98);
    cursor:grab;
    box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
}

button:focus {
    border-style: ridge;
    cursor:grabbing;
}

input {
    width: 95%;
    height: 80%;
    background-color: rgba(36, 91, 107, 0.3);
    border: none;
    font-family: 'Courier New', Courier, monospace;
    font-size: larger;
    text-align: center;
}

</style>