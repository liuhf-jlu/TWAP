subroutine HMD(length,hmd_ini_path)
!DEC$ ATTRIBUTES DLLEXPORT::HMD
!DEC$ ATTRIBUTES VALUE::length
!DEC$ ATTRIBUTES REFERENCE::hmd_ini_path
implicit none
integer ::fileid=10
integer ::num=0
integer ::linenum=0
integer ::record=1
character(len=7)str
character(len=100)hmddir
character(len=100)hmdfiledir
real :: pp=0.0

integer length
character(len=length),pointer::hmd_ini_path

!1000 converttx.ini
!2000 pcp1.pcp
open(unit=1000,file=hmd_ini_path,status='old')
read(1000,*)num	!read the num of pcpstation
read(1000,*)linenum	!read the line of pcp
read(1000,*)hmddir
write(*,*)hmddir
open(unit=2000,file=trim(hmddir),status='old')
read(2000,*)


do while(.true.)
  read(1000,*)hmdfiledir
  write(*,*)hmdfiledir
  open(unit=fileid,file=trim(hmdfiledir),status='old')
  fileid=fileid+1
  if((fileid-10)>num) then
    exit
  end if
end do

!reset fileid
fileid=10
!skip the first line
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
              	write(unit=2000,fmt='(F9.3)',advance='NO')pp
  			else
            	write(unit=2000,fmt='(F8.3)',advance='NO')pp
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
write(*,"('writing hmd.hmd completed!')")


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
