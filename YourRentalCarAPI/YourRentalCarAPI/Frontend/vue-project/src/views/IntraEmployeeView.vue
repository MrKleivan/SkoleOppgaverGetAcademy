<script setup>
import MainHeader from '@/components/MainHeader.vue';
import EmployeeIntra from '../components/EmployeeIntra.vue'
import IntraNavBar from '../components/IntraNavBar.vue'
</script>

<template>
    <MainHeader />
    <IntraNavBar />
    <br />
    <div class="employeeWrapper">
        <h1>Våre ansatte</h1><hr /><br>
        <EmployeeIntra />
    </div>
</template>

<style>

.employeeWrapper {
    width: 60%;
    max-height: fit-content;
    margin: auto;
    text-align: center;
}

</style>