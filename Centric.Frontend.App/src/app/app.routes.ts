import { Routes } from '@angular/router';

import { authGuard } from './auth/auth-guard';

import { AreaComponent } from './area/area.component';
import { HomeComponent } from './area/home/home.component';
import { LaunchComponent } from './launch/launch.component';
import { LoginComponent } from './login/login.component';

export const routes: Routes = [
    {
        path: '',
        pathMatch: 'full',
        component: LaunchComponent
    },
    {
        path: 'launch',
        component: LaunchComponent
    },
    {
        path: 'login',
        component: LoginComponent
    },
    {
        path: '',
        component: AreaComponent,
        canActivate: [authGuard],
        children: [
            {
                path: 'home',
                component: HomeComponent
            }
        ]
    },
    {
        path: '**',
        redirectTo: 'launch'
    }
];
