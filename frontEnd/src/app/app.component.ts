import { AngularFireDatabaseModule } from 'angularfire2/database';
import { Component } from '@angular/core';
import { AngularFireDatabase } from 'angularfire2/database';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  wallets: any[];

 constructor(db: AngularFireDatabase) {
   db.list('/wallets').valueChanges()
     .subscribe(wallets => {
       this.wallets = wallets;
       console.log(this.wallets);
     });
 }
}
