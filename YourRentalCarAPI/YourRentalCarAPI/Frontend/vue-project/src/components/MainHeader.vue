<script setup>
import NavBar from './NavBar.vue';
</script>

<template>
    <header>
        <div class="NavBarInHeader">
            <NavBar />
        </div>
    </header>
</template>


<style>

header {
    width: 100%;
    height: 18vh;
    background-color: aliceblue;
    text-align: right;
}

.NavBarInHeader {
    position: relative;
    align-content:end;
    width: 40%;
    height: 100%;
    margin: auto;

}

</style>