<template>
  <q-layout view="hHh lpR fFf">
    <q-header elevated class="bg-primary text-white">
      <q-toolbar>
        <q-btn dense flat round icon="menu" @click="toggleLeftDrawer" />

        <q-toolbar-title>
          <q-avatar>
            <img src="https://cdn.quasar.dev/logo-v2/svg/logo-mono-white.svg" />
          </q-avatar>
          <router-link class="q-ma-sm" to="/">LetSplit</router-link>
        </q-toolbar-title>
      </q-toolbar>
    </q-header>

    <q-drawer v-model="leftDrawerOpen" side="left" bordered>
      <!-- drawer content -->
    </q-drawer>

    <q-page-container>
      <h1><router-link to="/">LetSplit</router-link></h1>

      <q-btn class="q-ma-sm" color="white" text-color="black">
        <router-link to="/createEvent">Создать ивент</router-link>
      </q-btn>
      <!--      <q-btn class="q-ma-sm" color="blue-2" text-color="black" >-->
      <!--        <router-link to="/addsplits">Добавить расход</router-link>-->
      <!--      </q-btn>-->

      <router-view></router-view>
    </q-page-container>

    <q-page-container>
      <MoneyEventView v-if=""> 
      </MoneyEventView>
    </q-page-container>

    <q-footer elevated class="bg-grey-8 text-white">
      <q-toolbar>
        <q-toolbar-title>
          <q-avatar>
            <img src="https://cdn.quasar.dev/logo-v2/svg/logo-mono-white.svg" />
          </q-avatar>
          <div>Footer</div>
        </q-toolbar-title>
      </q-toolbar>
    </q-footer>
  </q-layout>
</template>

<script>
import CreateEvent from "@/views/MoneyCreateEvent.vue";
import AddSplits from "@/views/AddSplits.vue";
import MoneyEventView from "@/views/MoneyEventView.vue";
import { mapGetters, mapState } from "vuex";

export default {
  components: { MoneyEventView, AddSplits, CreateEvent },
  props: {

  },
  data() {
    return {
      leftDrawerOpen: false,
    };
  },
  computed: {
    ...mapGetters({
      myevent: "getEvent",
    }),

    ...mapState({}),
  },
  methods: {
    eventPage(){
      let event = this.getEvent
      event.
    },
    
    refreshUsers() {
      this.participants.forEach((partis) => {
        this.options.push({
          label: partis.name,
          value: partis.email,
          description: partis.email,
          icon: "mail",
        });
      });
      console.log(this.options);
    },

    toggleLeftDrawer() {
      this.leftDrawerOpen = !this.leftDrawerOpen;
    },
  },
};
</script>
<style>
* {
  color: inherit;
  text-decoration: inherit;
}
</style>
