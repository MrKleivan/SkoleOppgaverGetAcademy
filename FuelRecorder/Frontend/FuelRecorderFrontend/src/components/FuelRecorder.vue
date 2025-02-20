<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';


const FuelRecords = ref([]);
const error = ref(null);
const loading = ref(false)


const GetRecords = async () =>  {
    loading.value = true;
    error.value = null;
    FuelRecords.value = [];
    try {
        const token = localStorage.getItem('jwtToken');
        if(!token){
            throw new Error('Ingen token funnet. Vennligst logg inn');
        }
        console.log('Token:', token);
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

</script>

<template>
    <div>
        <div v-if="loading">Laster data...</div>
        <div v-if="error" class="error">{{ error }}</div>
        <table>
            <tbody>
                <tr>
                    <th>Kilometer</th>
                    <th>Mengde drivstoff fyldt</th>
                    <th>Betalt</th>
                </tr>
                <tr v-for="record in FuelRecords" :key="record.id">
                    <td>{{ record.kilometer }}</td>
                    <td>{{ record.fuelFilled }}</td>
                    <td>{{ record.price }}</td>
                </tr>
            </tbody>
        </table>
    </div>

</template>

<style scoped>

</style>