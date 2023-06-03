<template>
  <q-layout view="hHh lpR fFf">
    <q-header elevated class="bg-primary text-white">
      <q-toolbar>
        <q-btn dense flat round icon="menu" @click="toggleLeftDrawer" />

        <q-toolbar-title>
          <q-avatar>
            <img src="https://cdn.quasar.dev/logo-v2/svg/logo-mono-white.svg" />
          </q-avatar>
          LetSplit
        </q-toolbar-title>
      </q-toolbar>
    </q-header>

    <q-drawer v-model="leftDrawerOpen" side="left" bordered>
      <!-- drawer content -->
    </q-drawer>
    <router-link to="/createEvent">dsdsdsd</router-link>

    <q-page-container>
      <h1>LetSplit</h1>

      <!--      <CreateEvent-->
      <!--        :add-participant="addParticipant"-->
      <!--        :create-event="createEvent"-->
      <!--        :currencies="currencies"-->
      <!--        :currency="currency"-->
      <!--        :event-name="eventName"-->
      <!--        :participants="participants"-->
      <!--      />-->
      <router-view></router-view>
    </q-page-container>

    <!--    <AddSplits :create-event="createEvent" :refresh-users="refreshUsers" />-->

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

export default {
  components: { AddSplits, CreateEvent },
  props: {
    addParticipant: {},
    createEvent: {},
    currencies: {},
    currency: {},
    eventName: {},
    participants: {},
  },
  data() {
    return {
      leftDrawerOpen: false,
    };
  },
  methods: {
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
