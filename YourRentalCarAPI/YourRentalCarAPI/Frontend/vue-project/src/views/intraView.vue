<script setup>
import IntraNavBar from '@/components/IntraNavBar.vue';
import acsess from '../components/acsess.vue'
import form from '../components/acsess.vue'
console.log(form.acsessToken)
console.log(form.isLoggedInn)
</script>

<template>
    <main>
        <IntraNavBar />
        <h1>Du er i intranettet</h1>
    </main>
</template>