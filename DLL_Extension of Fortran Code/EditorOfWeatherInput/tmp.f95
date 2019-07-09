
subroutine TMP(length,tmp_ini_path)
!DEC$ ATTRIBUTES DLLEXPORT::TMP
!DEC$ ATTRIBUTES VALUE::length
!DEC$ ATTRIBUTES REFERENCE::tmp_ini_path
implicit none
integer ::fileid=10
integer ::num=0
integer ::linenum=0
integer ::record=1
character(len=100)tmpdir
character(len=100)tmpfiledir
character(len=7)str_date

character(len=10)str_min
character(len=10)str_max

real :: max=0.0
real :: min=0.0

integer length
character(len=length),pointer::tmp_ini_path

open(unit=1000,file=tmp_ini_path,status='old')
read(1000,*)num
read(1000,*)linenum
read(1000,*)tmpdir
write(*,*)tmpdir
open(unit=2000,file=trim(tmpdir),status='old')
read(2000,*)
read(2000,*)
read(2000,*)
read(2000,*)

do while(.true.)
  read(1000,*)tmpfiledir
  write(*,*)tmpfiledir
  open(unit=fileid,file=trim(tmpfiledir),status='old')
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
    		read(fileid,*)str_date
    		write(unit=2000,fmt='(A7)',advance='NO')str_date
  		else
  			read(fileid,*)str_max,str_min
            read(str_max,*)max	!convert string to real
            read(str_min,*)min
            if(max<0)then
              write(unit=2000,fmt='(F5.1)',advance='NO')max
            else
              write(unit=2000,fmt='(F5.1)',advance='NO')max
            end if
            if(min<0)then
              write(unit=2000,fmt='(F5.1)',advance='NO')min
            else
              write(unit=2000,fmt='(F5.1)',advance='NO')min
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
write(*,"('writing Tmp1.Tmp completed!')")


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

