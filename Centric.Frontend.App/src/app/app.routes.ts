import { Routes } from '@angular/router';
import { LaunchComponent } from './launch/launch.component';

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
        path: '**',
        redirectTo: 'launch'
    }
];
