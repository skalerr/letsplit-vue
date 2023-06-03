import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Quasar from "@/components/BaseComponents/Quasar.vue";
import MoneyView from "@/views/MoneyView.vue";
import MoneyCreateEvent from "@/views/MoneyCreateEvent.vue";

const routes = [{
            path: '/',
            name: 'home',
            component: HomeView
        },
        {
            path: '/about',
            name: 'about',
            // route level code-splitting
            // this generates a separate chunk (about.[hash].js) for this route
            // which is lazy-loaded when the route is visited.
            component: () =>
                import ( /* webpackChunkName: "about" */ '../views/AboutView.vue')
        },
        {
            path: '/quasar',
            name: 'quasar',
            component: Quasar
        },
        {
            path: '/money',
            name: 'money',
            component: MoneyView
        },
    {
        path: '/createEvent',
        name: 'createMoney',
        component: MoneyCreateEvent
    },
    ]
    // const router = createRouter({
    //     history: createWebHistory(),
    //     routes
    // })

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    routes
})

export default router