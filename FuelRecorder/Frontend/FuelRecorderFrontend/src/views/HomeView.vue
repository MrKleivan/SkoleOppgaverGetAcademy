<script setup>
import FuelRecorderView from './FuelRecorderView.vue';
import LogOut from '@/components/LogOut.vue';
</script>

<template>
  <main>
    <LogOut />
    <FuelRecorderView />
  </main>
</template>

<style scoped>

main {
  width: 80%;
  height: 100vh;
  align-content: center;
  margin: auto;
  overflow: scroll;
}

main::-webkit-scrollbar {
    visibility: hidden;
}
main::-webkit-scrollbar-corner {
    visibility: hidden;
}

</style>
