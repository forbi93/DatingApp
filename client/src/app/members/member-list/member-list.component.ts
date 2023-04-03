import { Component } from '@angular/core';
import { Member } from 'src/app/_models/members';
import { MembersService } from 'src/app/_services/members.service';
import {Observable} from "rxjs";


@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.scss']
})
export class MemberListComponent {
  members$: Observable<Member[]> | undefined;

  constructor(private memberService: MembersService) {
  }

  ngOnInit(): void {
    this.members$ = this.memberService.getMembers();
  }


}
