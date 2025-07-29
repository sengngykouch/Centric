import { Component } from '@angular/core';

import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@Component({
    selector: 'app-launch',
    imports: [MatProgressSpinnerModule],
    templateUrl: './launch.component.html',
    styleUrl: './launch.component.scss'
})
export class LaunchComponent {

}
