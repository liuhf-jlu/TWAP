
subroutine PCP(length,pcp_ini_path)
!DEC$ ATTRIBUTES DLLEXPORT::PCP
!DEC$ ATTRIBUTES VALUE::length
!DEC$ ATTRIBUTES REFERENCE::pcp_ini_path
implicit none
integer ::fileid=10
integer ::num=0
integer ::linenum=0
integer ::record=1
character(len=7)str
character(len=100)pcp1dir
character(len=100)pcpfiledir
integer length
character(len=length),pointer::pcp_ini_path
real :: pp=0.0

open(unit=1000,file=pcp_ini_path,status='old') ! open *.ini file
read(1000,*)num
read(1000,*)linenum
read(1000,*)pcp1dir
write(*,*)pcp1dir
open(unit=2000,file=trim(pcp1dir),status='old') !open *.pcp file
read(2000,*)
read(2000,*)
read(2000,*)
read(2000,*)
do while(.true.)
  read(1000,*)pcpfiledir
  write(*,*)pcpfiledir
  open(unit=fileid,file=trim(pcpfiledir),status='old')  !add ID to every file
  fileid=fileid+1
  if((fileid-10)>num) then
    exit
  end if
end do

fileid=10 !reset ID

do while(.true.)
  read(fileid,*)
  fileid=fileid+1
  if(fileid>(10+num))then
     exit
  end if
end do

!start at the second line
do while(.true.)
  	!operate one line
  	fileid=10
	do while(.true.)
  		if(fileid==10)then
    		read(fileid,*)str
    		write(unit=2000,fmt='(A7)',advance='NO')str
  		else
  			read(fileid,*)pp
            if(pp<0)then
              	write(unit=2000,fmt='(F6.1)',advance='NO')pp
  			else
            	write(unit=2000,fmt='(F5.1)',advance='NO')pp
            end if
  		end if
  		fileid=fileid+1
        if(fileid>(10+num))then
     		exit
  		end if
	end do
    !write Enter
    write(2000,*)
	record=record+1
    if(record>linenum)then
      exit
    end if
end do
write(*,"('writing pcp1.pcp completed!')")

fileid=10
!close every file
do while(.true.)
  close(fileid)
  fileid=fileid+1
  if(fileid>(10+num))then
     exit
  end if
end do
close(2000)
close(1000)

end subroutine

