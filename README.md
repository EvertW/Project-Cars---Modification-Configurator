# Project Cars - Modification Configurator
Simple modification configurator for Project Cars.

##Usage
Put the application in the 'Modifications' folder within the vehicles mods files.
Whithin the modifications vehicle folder create a file called modifications.xml, which is the configuration file for the car.

##Example modifications.xml
```<?xml version="1.0"?>
<Modifications vehicleName="Koenigsegg Regera">
    <Type name="TYPE">
        <Part>
            <Name>OPTION 1</Name>
            <ImagePath>/Modifications/VEHICLENAME/Images/IMAGE.png</ImagePath>
            <Items>
                <Path target="/Vehicles/VEHICLENAME/FILE_TO_REPLACE1.vhf">/Modifications/VEHICLENAME/TYPE/OPTION/FILE_TO_COPY1.vhf</Path>
                <Path target="/Vehicles/VEHICLENAME/FILE_TO_REPLACE2.vhf">/Modifications/VEHICLENAME/TYPE/OPTION/FILE_TO_COPY2.vhf</Path>
            </Items>
        </Part>
         <Part>
            <Name>OPTION 2</Name>
            <ImagePath>/Modifications/VEHICLENAME/Images/IMAGE.png</ImagePath>
            <Items>
                <Path target="/Vehicles/VEHICLENAME/FILE_TO_REPLACE1.vhf">/Modifications/VEHICLENAME/TYPE/OPTION/FILE_TO_COPY1.vhf</Path>
                <Path target="/Vehicles/VEHICLENAME/FILE_TO_REPLACE2.vhf">/Modifications/VEHICLENAME/TYPE/OPTION/FILE_TO_COPY2.vhf</Path>
            </Items>
        </Part>
    </Type>
</Modifications>
