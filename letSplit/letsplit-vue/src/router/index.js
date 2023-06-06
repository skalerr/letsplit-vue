import { createRouter, createWebHistory } from "vue-router";
import MoneyView from "@/views/MoneyView.vue";
import MoneyCreateEvent from "@/views/MoneyCreateEvent.vue";
import AddSplits from "@/views/AddSplits.vue";

const routes = [
  {
    path: "/",
    name: "home",
    component: MoneyView,
    children: [
      // Вложенные маршруты
      {
        path: "/createEvent",
        component: MoneyCreateEvent,
      },
      {
        path: "/addsplits",
        name: "addsplits",
        component: AddSplits,
      },
      // Другие вложенные маршруты
    ],
  },
  {
    path: "/quasar",
    name: "quasar",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
        import(/* webpackChunkName: "about" */ "../components/BaseComponents/Quasar.vue"),
  },
  {
    path: "/money",
    name: "money",
    component: MoneyView,
  },
];

// const router = createRouter({
//     history: createWebHistory(),
//     routes
// })

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
