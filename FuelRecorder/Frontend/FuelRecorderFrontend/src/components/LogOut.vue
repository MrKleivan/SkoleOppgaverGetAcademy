<script setup>
import { useRouter } from 'vue-router';

const router = useRouter();

const logout = () => {
  // Fjern tokenet fra localStorage
  localStorage.removeItem('jwtToken');
  
  // Naviger brukeren til innloggingssiden (eller en offentlig side)
  router.push({ name: 'login' });
};
</script>

<template>
    <div>
        <button @click="logout">Logg ut</button>
    </div>
</template>

<style scoped>

div {
    position: relative;
    top: 10px;
    left: 90vw;
    width: 100px;
    height: 20px;
}

</style>