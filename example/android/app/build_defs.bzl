"""Helper definitions to glob .aar and .jar targets"""

def create_aar_targets(aarfiles):
    for aarfile in aarfiles:
        name = "aars__" + aarfile[aarfile.rindex("/") + 1:aarfile.rindex(".aar")]
        lib_deps.append(":" + name)
        android_prebuilt_aar(
           